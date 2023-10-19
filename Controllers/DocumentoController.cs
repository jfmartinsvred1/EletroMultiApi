using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.DocumentoDTO;
using Microsoft.AspNetCore.Mvc;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentoController
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public DocumentoController(EletroMultiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ReadDocumentoDto> GetDocuments()
        {
            return _mapper.Map<List<ReadDocumentoDto>>(_context.Documentos);
        }
    }
}
