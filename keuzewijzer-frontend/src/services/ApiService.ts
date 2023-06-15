import AuthService from "./AuthService";

const LOGIN_PAGE_URL = "/login"; // Adjust this URL to match your login page's URL

export class ApiService {
  private readonly baseUrl: string;

  constructor(baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  private async handleUnauthorizedResponse(response: Response): Promise<void> {
    if (response.status === 401) {
      // Redirect the user to the login page
      window.location.href = LOGIN_PAGE_URL;
    } else {
      // If the response is not 401, throw an error
      throw new Error(`Request failed with status ${response.status}`);
    }
  }

  public async get<T>(url: string): Promise<T> {
    return fetch(`${this.baseUrl}${url}`, {
      credentials: "include"
    })
    .then(response => {
      if (response.status === 401) {
        return this.handleUnauthorizedResponse(response)
          .then(() => Promise.reject(`Request failed with status ${response.status}`));
      }
      
      return response.json();
    })
    .then(data => {
      console.log(data); // Handle the response data here
      return data; // Return the data to the caller
    })
    .catch(error => {
      console.log(error); // Handle the error here
      throw error; // Rethrow the error to the caller
    });
  }

  public async post<T>(url: string, data: any): Promise<T> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(data),
      credentials: "include"
    });

    if (!response.ok) {
      await this.handleUnauthorizedResponse(response);
    }

    return response.json();
  }

  public async put<T>(url: string, data: any): Promise<T> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(data),
      credentials: "include"
    });
  
    if (!response.ok) {
      await this.handleUnauthorizedResponse(response);
    }
  
    return response.json();
  }
  
  public async delete(url: string): Promise<Response> {
    const response = await fetch(`${this.baseUrl}${url}`, {
      method: "DELETE",
      credentials: "include"
    });

    if (!response.ok) {
      await this.handleUnauthorizedResponse(response);
    }

    return response;
  }
}
