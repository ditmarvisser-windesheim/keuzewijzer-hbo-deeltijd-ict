import { type IUser } from 'interfaces/iUser';
import { type IRole } from 'interfaces/iRole';

const baseUrl = 'https://localhost:7298';

export async function getAllUsers(): Promise<IUser[]> {
    const response = await fetch(baseUrl + '/api/User').then((response) => response.json());
    return response;
}

export async function getOneUser(id: string): Promise<IUser>{
    const response = await fetch(baseUrl + `/api/User/${id}`).then((response) => response.json());
    return response;
}

export async function updateUserSemesters(id: string, semesterIds: number[]): Promise<any> {
    const response = await fetch(baseUrl + `/api/User/UpdateSemesters/${id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(semesterIds)
    }).then((response) => response.json());

    return response;
}

export async function getUserRoles(id: string): Promise<IRole>{
  const response = await fetch(baseUrl + `/api/User/${id}/roles`).then((response) => response.json());
  return response;
}

export async function updateUserRoles(id: string, roles: string[]): Promise<any> {
    const response = await fetch(baseUrl + `/api/User/${id}/roles`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(roles)
    }).then((response) => response.json());

    return response;
}