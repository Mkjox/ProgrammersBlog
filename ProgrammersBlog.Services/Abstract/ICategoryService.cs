using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        /// <summary>
        /// İstenilen ID parametresine ait kategorileri getirir.
        /// </summary>
        /// <param name="categoryId">0'dan büyük integer bir ID değeri</param>
        /// <returns>Asenkron bir operasyon ile Task olarak verileri getirir.</returns>
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);

        /// <summary>
        /// Verilen ID parametresine ait kategorinin CategoryUpdateDto temsilini geriye döner.
        /// </summary>
        /// <param name="categoryId">0'dan büyük integer bir ID değeri</param>
        /// <returns>Asekron bir operasyon ile Task olarak işlem sonucu DataResult tipinde geriye döner.</returns>
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);

        /// <summary>
        /// Asenkron olarak tüm verileri getirir.
        /// </summary>
        /// <returns>Asenkron bir operasyon ile Task olarak işlem sonucunu DataResult tipinde geriye döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllAsync();

        /// <summary>
        /// Asenkron olarak silinmemiş tüm verileri getirir.
        /// </summary>
        /// <returns>Asenkron bir operasyon ile Task olarak silinmemiş tüm verileri DataResult tipinde geriye döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();

        /// <summary>
        /// Asenkron olarak silinmemiş ve aktif olan tüm verileri getirir.
        /// </summary>
        /// <returns>Asenkron bir operasyon ile Task olarak silinmemiş ve aktif olan tüm verileri DataResult tipinde geriye döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();

        Task<IDataResult<CategoryListDto>> GetAllByDeletedAsync();

        /// <summary>
        /// Verilen CategoryAddDto ve CreatedByName parametrelerine ait bilgiler ile yeni bir Category ekler.
        /// </summary>
        /// <param name="categoryAddDto">categoryAddDto tipinde eklenecek kategori bilgilerini verir.</param>
        /// <param name="createdByName">string tipinde kullanıcı adını verir.</param>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere ekleme işleminin sonucunu DataResult tipinde döner.</returns>
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createdByName);

        /// <summary>
        /// Verilen CategoryUpdateDto ve ModifiedByName parametrelerine ait bilgiler ile Kategoriyi günceller.
        /// </summary>
        /// <param name="categoryUpdateDto">categoryUpdateDto tipinde güncellenecek kategori bilgilerini verir.</param>
        /// <param name="modifiedByName">modifiedByName tipinde güncelleyen kullanıcı adını verir.</param>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere güncelleme işleminin sonucunu DataResult tipinde döner.</returns>
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);

        /// <summary>
        /// Verilen CategoryId ve ModifiedByName parametrelerine ait bilgiler ile Kategoriyi siler.
        /// </summary>
        /// <param name="categoryId">0'dan büyük integer bir ID değeri</param>
        /// <param name="modifiedByName">modifiedByName tipinde kategoriyi silen kullanıcı adını verir.</param>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere kategoriyi silme işleminin sonucunu DataResult tipinde döner.</returns>
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName);

        Task<IDataResult<CategoryDto>> UndoDeleteAsync(int categoryId, string modifiedByName);

        /// <summary>
        /// Verilen CategoryId parametresine ait bilgiler ile Kategoriyi Veritabanından siler.
        /// </summary>
        /// <param name="categoryId">0'dan büyük integer bir ID değeri</param>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere veritabanından kategoriyi silme işlemini DataResult tipinde döner.</returns>
        Task<IResult> HardDeleteAsync(int categoryId);

        /// <summary>
        /// Asenkron olarak kategorilerin sayısını döner.
        /// </summary>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere Kategori sayısını döndürür.</returns>
        Task<IDataResult<int>> CountAsync();

        /// <summary>
        /// Asenkron olarak silinmemiş kategorilerin sayısını döner.
        /// </summary>
        /// <returns>Asenkron bir operasyon ile Task olarak bizlere silinmemiş Kategori sayısını döndürür.</returns>
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
