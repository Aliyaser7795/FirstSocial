import type { BookDto, GetBooksInput } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  apiName = 'Default';

  editPriceBookByIdAndPrice = (id: string, price: number) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: `/api/app/book/${id}/edit-price-book`,
      params: { price },
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, BookDto>({
      method: 'GET',
      url: `/api/app/book/${id}`,
    },
    { apiName: this.apiName });

  getCount = (id: string) =>
    this.restService.request<any, BookDto>({
      method: 'GET',
      url: `/api/app/book/${id}/count`,
    },
    { apiName: this.apiName });

  getList = (input: GetBooksInput) =>
    this.restService.request<any, PagedResultDto<BookDto>>({
      method: 'GET',
      url: '/api/app/book',
      params: { name: input.name, type: input.type, publishDate: input.publishDate, borrowpuy: input.borrowpuy, price: input.price, isBorrowed: input.isBorrowed, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  rent = (id: string) =>
    this.restService.request<any, boolean>({
      method: 'POST',
      url: `/api/app/book/${id}/rent`,
    },
    { apiName: this.apiName });

  returnBookById = (id: string) =>
    this.restService.request<any, boolean>({
      method: 'POST',
      url: `/api/app/book/${id}/return-book`,
    },
    { apiName: this.apiName });

  countbookIsBorrowed = () =>
    this.restService.request<any, number>({
      method: 'POST',
      url: '/api/app/book/countbook-is-borrowed',
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
