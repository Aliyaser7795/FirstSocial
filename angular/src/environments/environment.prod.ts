import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'FirstSocial',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44395',
    redirectUri: baseUrl,
    clientId: 'FirstSocial_App',
    responseType: 'code',
    scope: 'offline_access FirstSocial',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44395',
      rootNamespace: 'FirstSocial',
    },
  },
} as Environment;
