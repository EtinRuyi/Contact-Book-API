﻿namespace ContactBookAPI.Model.DTOs
{
    public class PaginationFilterDto
    {
        public int CurrentPage { get; set; }
        public PaginationFilterDto()
        {
            this.CurrentPage = 1;
        }
        public PaginationFilterDto(int CurrentPage)
        {
            this.CurrentPage = CurrentPage <= 0 ? 1 : CurrentPage;
        }
    }
}