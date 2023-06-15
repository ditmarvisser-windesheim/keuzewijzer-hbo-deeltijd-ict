import { type ISemester } from '../interfaces/iSemester';

const baseUrl = 'https://localhost:7298';

export async function getAllSemesters(): Promise<ISemester[]> {
    const response = await fetch(baseUrl + '/api/semesterItem').then((response) => response.json());

    return response;
}

export async function getOneSemester(id: string): Promise<ISemester>{
    const response = await fetch(baseUrl + `/api/semesterItem/${id}`).then((response) => response.json());

    return response;
}

export async function createSemester(semester: ISemester): Promise<any> {
    const response = await fetch(baseUrl + '/api/semesterItem', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(semester)
    }).then((response) => response.json());

    return response;
}

export async function updateSemester(id: number, semester: ISemester): Promise<any> {
    const response = await fetch(baseUrl + `/api/semesterItem/${id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(semester)
    }).then((response) => response.json());

    return response;
}

export async function removeSemester(id: string): Promise<any> {
    const response = await fetch(baseUrl + `/api/semesterItem/${id}`, {
      method: 'DELETE'
    });

    return response;
}
