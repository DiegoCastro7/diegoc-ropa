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
public class DetalleOrdenController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetalleOrdenController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetalleOrden>>> Get()
        {
            var entidades = await _unitOfWork.DetalleOrdens.GetAllAsync();
            return _mapper.Map<List<DetalleOrden>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleOrdenDto>> Get(int id)
        {
            var entidad = await _unitOfWork.DetalleOrdens.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<DetalleOrdenDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DetalleOrden>> Post(DetalleOrdenDto DetalleOrdenDto)
        {
            var entidad = _mapper.Map<DetalleOrden>(DetalleOrdenDto);
            this._unitOfWork.DetalleOrdens.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            DetalleOrdenDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = DetalleOrdenDto.Id}, DetalleOrdenDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleOrdenDto>> Put(int id, [FromBody] DetalleOrdenDto DetalleOrdenDto)
        {
            if(DetalleOrdenDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<DetalleOrden>(DetalleOrdenDto);
            _unitOfWork.DetalleOrdens.Update(entidades);
            await _unitOfWork.SaveAsync();
            return DetalleOrdenDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.DetalleOrdens.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.DetalleOrdens.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
