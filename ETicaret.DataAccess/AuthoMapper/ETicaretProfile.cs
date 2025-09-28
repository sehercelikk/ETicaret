using AutoMapper;
using ETicaret.Dto.Concrete.SingleDto;
using ETicaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.AuthoMapper;

public class ETicaretProfile : Profile
{
    public ETicaretProfile()
    {
        CreateMap<CategoryDto, Category>().ReverseMap();
    }
}
