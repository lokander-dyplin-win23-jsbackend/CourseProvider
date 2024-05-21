using CourseProvider.Infrastructure.Data.Contexts;
using CourseProvider.Infrastructure.Data.Entities;
using CourseProvider.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProvider.Infrastructure.Services;

public interface ICourseService
{
    Task<Course> CreateCourseAsync(CourseCreateRequest request);
    Task<Course> GetCourseByIdAsync(string id);
    Task<IEnumerable<Course>> GetCoursesAsync();
    Task<Course> UpdateCourseAsync(CourseUpdateRequest request);
    Task<bool> DeleteCourseAsync(string id);
}

public class CourseService(IDbContextFactory<DataContext> contextFactory) : ICourseService
{

    private readonly IDbContextFactory<DataContext> _contextFactory = contextFactory;

    public async Task<Course> CreateCourseAsync(CourseCreateRequest request)
    {
        await using var context = _contextFactory.CreateDbContext();


        context.Courses.Add(courseEntity);
        await context.SaveChangesAsync();
    }

    public Task<bool> DeleteCourseAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Course> GetCourseByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Course> UpdateCourseAsync(CourseUpdateRequest request)
    {
        throw new NotImplementedException();
    }
}
