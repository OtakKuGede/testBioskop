using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Studio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Service
{
    public class MsStudioService : IMsStudioService
    {
        BioskopContext dbContext;

        public MsStudioService(BioskopContext _db)
        {
            dbContext = _db;
        }

        public StudioResponseDto GetStudio()
        {
            StudioResponseDto studio = new StudioResponseDto();
            List <MsStudio> p = dbContext.MsStudios.ToList();
            List <StudioResponse> res = new List<StudioResponse>();
            studio.jumlah = p.Count;
            studio.data = res;
            foreach(MsStudio x in dbContext.MsStudios)
            {
                StudioResponse pon = new StudioResponse();
                pon.NamaStudio = x.NamaStudio;
                pon.TypeStudio = x.TypeStudio;
                pon.HargaWeekend = x.HargaWeekend;
                pon.HargaHariBiasa = x.HargaHariBiasa;
                res.Add(pon);
            }
            return studio;
        }
        public StudioResponseDto2 AddStudio(MsStudio po)
        {
            StudioResponseDto2 y = new StudioResponseDto2();
            int jumlah = 0;
            MsStudio masuk = new MsStudio();
            List<StudioResponse> res = new List<StudioResponse>();
            StudioResponse lol = new StudioResponse();
            y.data = res;
            foreach(MsStudio b in dbContext.MsStudios)
            {
                
                if (po.NamaStudio == b.NamaStudio)
                {
                    jumlah++;
                }
            }
            if(jumlah > 0)
            {
                y.message = po.NamaStudio + " Sudah Terdaftar";
                y.data = null;
            }
            if (jumlah == 0)
            {
                masuk.IdStudio = Guid.NewGuid();
                masuk.IdBioskop = po.IdBioskop;
                masuk.NamaStudio = po.NamaStudio;
                masuk.TypeStudio = po.TypeStudio;
                masuk.HargaWeekend = po.HargaWeekend;
                masuk.HargaHariBiasa = po.HargaHariBiasa;
                lol.NamaStudio = po.NamaStudio;
                lol.TypeStudio = po.TypeStudio;
                lol.HargaWeekend = po.HargaWeekend;
                lol.HargaHariBiasa = po.HargaHariBiasa;
                dbContext.MsStudios.Add(masuk);
                dbContext.SaveChanges();
                res.Add(lol);
                y.message = masuk.NamaStudio + " Berhasil Ditambahkan";
            }
            
            return y;
        }
        public StudioResponseDto2 UpdateStudio(MsStudio o)
        {
            StudioResponseDto2 x = new StudioResponseDto2();
            MsStudio a = dbContext.MsStudios.Find(o.IdStudio);
            if (a == null)
            {
                x.message = "Id Studio " + o.IdStudio + " Tidak dapat ditemukan";
                x.data = null;    
            }
            if (a != null)
            {
                x.message = "Id Studio " + o.IdStudio + " berhasil di update";
                StudioResponse l = new StudioResponse();
                a.IdStudio = o.IdStudio;
                a.NamaStudio = o.NamaStudio;
                a.HargaWeekend = o.HargaWeekend;
                a.HargaHariBiasa = o.HargaHariBiasa;
                a.IdBioskop = o.IdBioskop;
                l.NamaStudio = o.NamaStudio;
                l.TypeStudio = o.TypeStudio;
                l.HargaHariBiasa = o.HargaHariBiasa;
                l.HargaWeekend = o.HargaWeekend;
                dbContext.MsStudios.Update(a);
                dbContext.SaveChanges();
                List<StudioResponse> d = new List<StudioResponse>();
                d.Add(l);
                x.data = d;
            }
            return x;
        }
        public StudioResponseDto2 DeleteStudio(Guid IdStudio)
        {
            StudioResponseDto2 x = new StudioResponseDto2();
            MsStudio b = dbContext.MsStudios.Find(IdStudio);
            StudioResponse l = new StudioResponse();
            List<StudioResponse> p = new List<StudioResponse>();
            p.Add(l);
            x.data = p;
            if (b == null)
            {
                x.message = IdStudio + " Tidak dapat ditemukan";
                
            }
            if (b != null)
            {
                l.NamaStudio = b.NamaStudio;
                l.TypeStudio = b.TypeStudio;
                l.HargaHariBiasa = b.HargaHariBiasa;
                l.HargaWeekend = b.HargaWeekend;
                x.message = IdStudio + " Berhasil dihapus";
                dbContext.MsStudios.Remove(b);
                dbContext.SaveChanges();
            }
            return x;
        }
    }
}
