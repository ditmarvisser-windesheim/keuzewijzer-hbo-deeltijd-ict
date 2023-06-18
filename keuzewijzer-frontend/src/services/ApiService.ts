import AuthService from './AuthService';

const LOGIN_PAGE_URL = '/login'; // Adjust this URL to match your login page's URL

export class ApiService {
  private readonly baseUrl: string;

  constructor (baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  private async handleUnauthorizedResponse (response: Response): Promise<void> {
    if (response.status === 401) {
      // Redirect the user to the login page
      window.location.href = LOGIN_PAGE_URL;
    } else {
      // If the response is not 401, throw an error
      throw new Error(`Request failed with status ${response.status}`);
    }
  }

  public async get<T>(url: string): Promise<T> {
    return await fetch(`${this.baseUrl}${url}`, {
      credentials: 'include'
    })
      .then(async response => {
        if (response.status === 401) {
          return await this.handleUnauthorizedResponse(response)
            .then(async () => await Promise.reject(`Request failed with status ${response.status}`));
        }

        return await response.json();
      })
      .catch(error => {
        console.log('catch', error);
        throw error;
      });
  }

  public async post<T>(url: string, data: any): Promise<T> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(data),
      credentials: 'include'
    });

    // If url is not login and response is not ok, redirect to login page
    if (!response.ok && url !== '/api/Auth/login') {
      await this.handleUnauthorizedResponse(response);
    }

    return await response.json();
  }

  public async put<T>(url: string, data: any): Promise<T> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(data),
      credentials: 'include'
    });

    if (!response.ok) {
      await this.handleUnauthorizedResponse(response);
    }

    return await response.json();
  }

  public async delete (url: string): Promise<Response> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: 'DELETE',
      credentials: 'include'
    });

    if (!response.ok) {
      await this.handleUnauthorizedResponse(response);
    }

    return response;
  }
}
