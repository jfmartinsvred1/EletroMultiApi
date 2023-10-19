using AutoMapper;
using EletroMultiAPI.Data.DTOS.DocumentoDTO;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class DocumentoProfile:Profile
    {
        public DocumentoProfile()
        {
            CreateMap<CreateDocumentoDto, Documento>();
            CreateMap<Documento,ReadDocumentoDto>();
        }
    }
}
