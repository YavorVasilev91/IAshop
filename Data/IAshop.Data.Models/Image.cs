namespace IAshop.Data.Models
{
    using System;

    using IAshop.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }

        // The contents of the image is in the file system
    }
}
