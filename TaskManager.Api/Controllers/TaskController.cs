// Controllers/TaskController.cs
using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Data;
using TaskManager.Api.Models;

[Route("api/tasks")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TaskController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetTasks()
    {
        var tasks = _context.Tareas.ToList();
        return Ok(tasks);
    }

    [HttpPost]
    public IActionResult CreateTask([FromBody] Tarea tarea)
    {
        _context.Tareas.Add(tarea);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetTasks), new { id = tarea.Id }, tarea);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, [FromBody] Tarea tarea)
    {
        var existingTask = _context.Tareas.Find(id);
        if (existingTask == null)
        {
            return NotFound();
        }

        existingTask.Titulo = tarea.Titulo;
        existingTask.Descripcion = tarea.Descripcion;
        existingTask.Estado = tarea.Estado;
        existingTask.FechaActualizacion = DateTime.Now;

        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var task = _context.Tareas.Find(id);
        if (task == null)
        {
            return NotFound();
        }

        _context.Tareas.Remove(task);
        _context.SaveChanges();
        return NoContent();
    }
}
