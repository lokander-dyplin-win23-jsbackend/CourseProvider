using CourseProvider.Infrastructure.Services;
using CourseProvider.Infrastructure.Models;

namespace CourseProvider.Infrastructure.GraphQL;

public class Query(ICourseService courseService)
{
    private readonly ICourseService _courseService = courseService;

    [GraphQLName("getAllCourses")]

    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _courseService.GetCoursesAsync();
    }

    [GraphQLName("getCourseById")] 

    public async Task <Course> GetCourseByIdAsync(string id)
    {
        return await _courseService.GetCourseByIdAsync(id);
    }

}
