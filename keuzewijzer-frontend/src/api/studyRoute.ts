import { IStudyRoute } from "interfaces/iStudyRoute";

const baseUrl = 'https://localhost:7298';

export async function getUserStudyRoute(userId: string): Promise<IStudyRoute[]> {
    const response = await fetch(baseUrl + `/api/StudyRoute/user/${userId}`).then((response) => response.json());

    return response;
}

export async function createStudyRoute(studyRoute: IStudyRoute): Promise<any> {
    const response = await fetch(baseUrl + '/api/StudyRoute', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(studyRoute)
    }).then((response) => response.json());

    return response;
}