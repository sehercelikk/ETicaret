using AutoMapper;
using ETicaret.Dto.Concrete.AddDto;
using ETicaret.Dto.Concrete.SingleDto;
using ETicaret.Entities.Concrete;

namespace ETicaret.DataAccess.AuthoMapper;

public class ETicaretProfile : Profile
{
    public ETicaretProfile()
    {
        // Single Dto Reverse
        CreateMap<CategoryDto, Category>().ReverseMap();
        CreateMap<BrandDto, Brand>().ReverseMap();
        CreateMap<BranchDto, Branch>().ReverseMap();
        CreateMap<ProductDto,Product>().ReverseMap();
        CreateMap<ProductImageDto, ProductImage>().ReverseMap();


        // AddDto Reverse
        CreateMap<AddCategoryDto,Category>().ReverseMap();
        CreateMap<AddBrandDto,Brand>().ReverseMap();
        CreateMap<AddBranchDto,Branch>().ReverseMap();
        CreateMap<AddProductDto,ProductImage>().ReverseMap();
        CreateMap<AddProductImageDto,ProductImage>().ReverseMap();

        // Add To Single Dto
        CreateMap<AddCategoryDto, CategoryDto>().ReverseMap();
        CreateMap<AddBrandDto,BrandDto>().ReverseMap();
        CreateMap<AddBranchDto,BranchDto>().ReverseMap();
        CreateMap<AddProductDto, ProductDto>().ReverseMap();
        CreateMap<AddProductImageDto, ProductImageDto>().ReverseMap();

    }
}
