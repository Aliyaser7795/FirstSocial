import type { AuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import type { BookType } from './book-type.enum';

export interface BookDto extends AuditedEntityDto<string> {
  name?: string;
  type: BookType;
  publishDate?: string;
  borrowBy?: string;
  isBorrowed: boolean;
  borrowStartDate?: string;
  borrowEndDate?: string;
  price: number;
}

export interface GetBooksInput extends PagedAndSortedResultRequestDto {
  name?: string;
  type: BookType;
  publishDate?: string;
  borrowpuy?: string;
  price: number;
  isBorrowed: boolean;
}
