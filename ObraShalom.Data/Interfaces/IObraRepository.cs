﻿using ObraShalom.Domain.Entities;

namespace ObraShalom.Data.Interfaces
{
    public interface IObraRepository
    {
        Task<IEnumerable<ObraDto>> ObtenerObra();
        Task<ObraDto> ObtenerObra(int id, bool? active = true);
    }
}
