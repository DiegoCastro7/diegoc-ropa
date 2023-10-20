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
public class TipoEstadoController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoEstadoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoEstado>>> Get()
        {
            var entidades = await _unitOfWork.TipoEstados.GetAllAsync();
            return _mapper.Map<List<TipoEstado>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoEstadoDto>> Get(int id)
        {
            var entidad = await _unitOfWork.TipoEstados.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoEstadoDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoEstado>> Post(TipoEstadoDto TipoEstadoDto)
        {
            var entidad = _mapper.Map<TipoEstado>(TipoEstadoDto);
            this._unitOfWork.TipoEstados.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            TipoEstadoDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = TipoEstadoDto.Id}, TipoEstadoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoEstadoDto>> Put(int id, [FromBody] TipoEstadoDto TipoEstadoDto)
        {
            if(TipoEstadoDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<TipoEstado>(TipoEstadoDto);
            _unitOfWork.TipoEstados.Update(entidades);
            await _unitOfWork.SaveAsync();
            return TipoEstadoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.TipoEstados.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoEstados.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
