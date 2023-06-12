const baseUrl = 'https://localhost:7298';

export async function login (payload: any): Promise<any> {
  const url = '/api/Auth/login';

  try {
    const response = await fetch(baseUrl + url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(payload)
    }).then(async (response) => await response.json());

    return response;
  } catch (error) {
    throw new Error('Login failed');
  }
}

export async function logout (payload: any): Promise<any> {
  const url = '/api/Auth/logout';

  try {
    const response = await fetch(baseUrl + url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(payload)
    }).then(async (response) => await response.json());

    return response;
  } catch (error) {
    throw new Error('Login failed');
  }
}
