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
public class TipoProteccionController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoProteccionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoProteccion>>> Get()
        {
            var entidades = await _unitOfWork.TipoProteccions.GetAllAsync();
            return _mapper.Map<List<TipoProteccion>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoProteccionDto>> Get(int id)
        {
            var entidad = await _unitOfWork.TipoProteccions.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoProteccionDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoProteccion>> Post(TipoProteccionDto TipoProteccionDto)
        {
            var entidad = _mapper.Map<TipoProteccion>(TipoProteccionDto);
            this._unitOfWork.TipoProteccions.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            TipoProteccionDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = TipoProteccionDto.Id}, TipoProteccionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoProteccionDto>> Put(int id, [FromBody] TipoProteccionDto TipoProteccionDto)
        {
            if(TipoProteccionDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<TipoProteccion>(TipoProteccionDto);
            _unitOfWork.TipoProteccions.Update(entidades);
            await _unitOfWork.SaveAsync();
            return TipoProteccionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.TipoProteccions.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoProteccions.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
