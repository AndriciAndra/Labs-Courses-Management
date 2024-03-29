﻿using LabsAndCoursesManagement.BusinessLogic.Interfaces;
using LabsAndCoursesManagement.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LabsAndCoursesManagement.WebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/teachers")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService service;

        public TeachersController(ITeacherService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok((await service.GetAll()).Entity);
        }

        [HttpGet("{teacherId:guid}")]
        public async Task<IActionResult> GetById(Guid teacherId)
        {
            var result = await service.GetById(teacherId);
            if (result.IsFailure)
            {
                return StatusCode((int)result.StatusCode, result.Error);
            }
            return Ok(result.Entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTeacherDto dto)
        {
            var result = await service.Add(dto);
            if (result.IsFailure)
            {
                return StatusCode((int)result.StatusCode, result.Error);
            }
            return Created(nameof(Get), result.Entity);
        }

        [HttpDelete("{teacherId:guid}")]
        public async Task<IActionResult> DeleteById(Guid teacherId)
        {
            var result = await service.Delete(teacherId);
            if (result.IsFailure)
            {
                return StatusCode((int)result.StatusCode, result.Error);
            }
            return Ok();
        }

        [HttpPut("{teacherId:guid}")]
        public async Task<IActionResult> Update(Guid teacherId, [FromBody] CreateTeacherDto dto)
        {
            var result = await service.Update(teacherId, dto);
            if (result.IsFailure)
            {
                return StatusCode((int)result.StatusCode, result.Error);
            }
            return Ok(result.Entity);
        }

        [HttpPut("{teacherId:guid}/enroll")]
        public async Task<IActionResult> EnrollTeacherToLab(Guid teacherId, [FromBody] List<Guid> labIds)
        {
            var result = await service.EnrollTeacherToLabs(teacherId, labIds);
            return Ok(result);
        }
    }
}
