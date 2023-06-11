namespace Api {
  // TODO: change this to env
  export const baseUrl = 'https://localhost:7298';

  export async function get (url: string): Promise<any> {
    const response = await fetch(baseUrl + url);
    return await response.json();
  }

  export async function post (url: string, payload: any): Promise<any> {
    const response = await fetch(baseUrl + url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(payload)
    });
    return await response.json();
  }

  export async function put (url: string, payload: any): Promise<any> {
    const response = await fetch(baseUrl + url, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(payload)
    });
    return await response.json();
  }

  export async function remove (url: string): Promise<any> {
    const response = await fetch(baseUrl + url, {
      method: 'DELETE'
    });
    return response;
  }
}

export default Api;
