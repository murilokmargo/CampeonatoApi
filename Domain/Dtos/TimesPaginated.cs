using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class TimesPaginated 
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public IEnumerable<TimeDTOCreateResult> Data { get; set; }
        public TimesPaginated(IEnumerable<TimeDTOCreateResult> data, int dataQuantity, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.TotalRecords = dataQuantity;
            this.TotalPages = (int)Math.Ceiling((double)dataQuantity / pageSize);
        }
    }
}
