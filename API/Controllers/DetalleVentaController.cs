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
public class DetalleVentaController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetalleVentaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> Get()
        {
            var entidades = await _unitOfWork.DetalleVentas.GetAllAsync();
            return _mapper.Map<List<DetalleVenta>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleVentaDto>> Get(int id)
        {
            var entidad = await _unitOfWork.DetalleVentas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<DetalleVentaDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DetalleVenta>> Post(DetalleVentaDto DetalleVentaDto)
        {
            var entidad = _mapper.Map<DetalleVenta>(DetalleVentaDto);
            this._unitOfWork.DetalleVentas.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            DetalleVentaDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = DetalleVentaDto.Id}, DetalleVentaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleVentaDto>> Put(int id, [FromBody] DetalleVentaDto DetalleVentaDto)
        {
            if(DetalleVentaDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<DetalleVenta>(DetalleVentaDto);
            _unitOfWork.DetalleVentas.Update(entidades);
            await _unitOfWork.SaveAsync();
            return DetalleVentaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.DetalleVentas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.DetalleVentas.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
