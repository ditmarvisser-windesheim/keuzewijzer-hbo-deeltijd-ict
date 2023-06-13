import { type ICohort } from 'interfaces/iCohort';
import { ISemesterItem } from 'interfaces/iSemesterItems';

const baseUrl = 'https://localhost:7298';

export async function getCohorts(): Promise<ICohort[]> {
  const response = await fetch(baseUrl + '/api/Cohort').then((response) => response.json());
  return response;
}

export async function getCohort(year: number): Promise<ISemesterItem[]> {
  const response = await fetch(baseUrl+ `/api/Cohort/${year}`).then((response) => response.json());
 
  return response;
}

export async function createCohort(cohort: ICohort) {
  const response = await fetch(baseUrl+ '/api/Cohort', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(cohort)
  }).then((response) => response.json());

  return response;
}

export async function removeCohort(id: string): Promise<any> {
  const response = await fetch(baseUrl + `/api/Cohort/${id}`, {
    method: 'DELETE'
  });

  return response;
}