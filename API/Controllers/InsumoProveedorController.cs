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
public class InsumoProveedorController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InsumoProveedorController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InsumoProveedor>>> Get()
        {
            var entidades = await _unitOfWork.InsumoProveedors.GetAllAsync();
            return _mapper.Map<List<InsumoProveedor>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsumoProveedorDto>> Get(int id)
        {
            var entidad = await _unitOfWork.InsumoProveedors.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<InsumoProveedorDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InsumoProveedor>> Post(InsumoProveedorDto InsumoProveedorDto)
        {
            var entidad = _mapper.Map<InsumoProveedor>(InsumoProveedorDto);
            this._unitOfWork.InsumoProveedors.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            InsumoProveedorDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = InsumoProveedorDto.Id}, InsumoProveedorDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsumoProveedorDto>> Put(int id, [FromBody] InsumoProveedorDto InsumoProveedorDto)
        {
            if(InsumoProveedorDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<InsumoProveedor>(InsumoProveedorDto);
            _unitOfWork.InsumoProveedors.Update(entidades);
            await _unitOfWork.SaveAsync();
            return InsumoProveedorDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.InsumoProveedors.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.InsumoProveedors.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
