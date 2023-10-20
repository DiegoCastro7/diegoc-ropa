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
public class MunicipioController: BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MunicipioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Municipio>>> Get()
        {
            var entidades = await _unitOfWork.Municipios.GetAllAsync();
            return _mapper.Map<List<Municipio>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MunicipioDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Municipios.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<MunicipioDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Municipio>> Post(MunicipioDto MunicipioDto)
        {
            var entidad = _mapper.Map<Municipio>(MunicipioDto);
            this._unitOfWork.Municipios.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            MunicipioDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = MunicipioDto.Id}, MunicipioDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MunicipioDto>> Put(int id, [FromBody] MunicipioDto MunicipioDto)
        {
            if(MunicipioDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Municipio>(MunicipioDto);
            _unitOfWork.Municipios.Update(entidades);
            await _unitOfWork.SaveAsync();
            return MunicipioDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Municipios.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Municipios.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
