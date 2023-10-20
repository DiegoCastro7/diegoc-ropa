using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class InsumoPrendaController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InsumoPrendaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InsumoPrenda>>> Get()
        {
            var entidades = await _unitOfWork.InsumoPrendas.GetAllAsync();
            return _mapper.Map<List<InsumoPrenda>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsumoPrendaDto>> Get(int id)
        {
            var entidad = await _unitOfWork.InsumoPrendas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<InsumoPrendaDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InsumoPrenda>> Post(InsumoPrendaDto InsumoPrendaDto)
        {
            var entidad = _mapper.Map<InsumoPrenda>(InsumoPrendaDto);
            this._unitOfWork.InsumoPrendas.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            InsumoPrendaDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = InsumoPrendaDto.Id}, InsumoPrendaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsumoPrendaDto>> Put(int id, [FromBody] InsumoPrendaDto InsumoPrendaDto)
        {
            if(InsumoPrendaDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<InsumoPrenda>(InsumoPrendaDto);
            _unitOfWork.InsumoPrendas.Update(entidades);
            await _unitOfWork.SaveAsync();
            return InsumoPrendaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.InsumoPrendas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.InsumoPrendas.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
