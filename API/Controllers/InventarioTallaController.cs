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
public class InventarioTallaController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InventarioTallaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InventarioTalla>>> Get()
        {
            var entidades = await _unitOfWork.InventarioTallas.GetAllAsync();
            return _mapper.Map<List<InventarioTalla>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioTallaDto>> Get(int id)
        {
            var entidad = await _unitOfWork.InventarioTallas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<InventarioTallaDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InventarioTalla>> Post(InventarioTallaDto InventarioTallaDto)
        {
            var entidad = _mapper.Map<InventarioTalla>(InventarioTallaDto);
            this._unitOfWork.InventarioTallas.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            InventarioTallaDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = InventarioTallaDto.Id}, InventarioTallaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioTallaDto>> Put(int id, [FromBody] InventarioTallaDto InventarioTallaDto)
        {
            if(InventarioTallaDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<InventarioTalla>(InventarioTallaDto);
            _unitOfWork.InventarioTallas.Update(entidades);
            await _unitOfWork.SaveAsync();
            return InventarioTallaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.InventarioTallas.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.InventarioTallas.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
