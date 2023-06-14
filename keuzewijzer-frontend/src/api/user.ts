import { type IUser } from 'interfaces/iUser';

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

// export async function put
