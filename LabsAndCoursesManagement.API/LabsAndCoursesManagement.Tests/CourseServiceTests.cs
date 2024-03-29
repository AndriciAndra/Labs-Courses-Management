﻿using FluentAssertions;
using LabsAndCoursesManagement.BusinessLogic.Services;
using LabsAndCoursesManagement.DataAccess.Repositories;
using LabsAndCoursesManagement.Models.Dtos;
using LabsAndCoursesManagement.Models.Helpers;
using LabsAndCoursesManagement.Models.Models;
using Moq;

namespace LabsAndCoursesManagement.Tests
{
    public class CourseServiceTests
    {
        private readonly Mock<IRepository<Course>> repository = new();
        private CourseService service;
        [SetUp]
        public void Setup()
        {
            service = new CourseService(repository.Object);
            
        }

        [Test]
        public async Task When_AddedNewCourse_Then_ShouldHaveIsSuccessTrue()
        {
            // Arrange
            var courseDto = CreateSUT();
            // Act
            repository.Setup(x => x.Add(It.IsAny<Course>())).Returns(Task.FromResult((Course?) new Course()));
            var response = await service.Add(courseDto);
            // Assert
            response.IsSuccess.Should().BeTrue();
        }
        [Test]
        public async Task When_AddedNewCourseWithEmptyName_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var course = CreateSUT();
            course.Name = "";
            // Act
            var response = await service.Add(course);
            // Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Test]
        public async Task When_AddedNewCourseWithTooLongName_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var course = CreateSUT();
            course.Name = string.Concat(Enumerable.Repeat("Hello", 100));
            // Act
            var response = await service.Add(course);
            // Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Test]
        public async Task When_AddedNewCourseWithTooLongDescription_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var course = CreateSUT();
            course.Description = string.Concat(Enumerable.Repeat("Hello", 100));
            // Act
            var response = await service.Add(course);
            // Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Test]
        public async Task When_AddedNewCourseWithDefaultValueForYear_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var course = CreateSUT();
            course.Year = 0;
            // Act
            var response = await service.Add(course);
            // Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

            [Test]
            public async Task When_AddedNewCourseWithTooHighValueForYear_Then_ShouldReturnBadRequest()
            {
                // Arrange
                var course = CreateSUT();
                course.Year = 7;
                // Act
                var response = await service.Add(course);
                // Assert
                response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
            }

            [Test]
            public async Task When_AddedNewCourseWithDefaultValueForSemester_Then_ShouldReturnBadRequest()
            {
                // Arrange
                var course = CreateSUT();
                course.Semester = 0;
                // Act
                var response = await service.Add(course);
                // Assert
                response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
            }

        [Test]
        public async Task When_AddedNewCourseWithTooHighValueForSemester_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var course = CreateSUT();
            course.Semester = 3;
            // Act
            var response = await service.Add(course);
            // Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        private static CreateCourseDto CreateSUT()
        {
            return new CreateCourseDto
            {
                Name = "New Name",
                Description = "Description",
                Semester = 1,
                Year = 1,
            };
        }
    }
}