import { type IRole } from 'interfaces/iRole';

const baseUrl = 'https://localhost:7298';

export async function getAllRoles (): Promise<IRole[]> {
  const response = await fetch(baseUrl + '/api/Role').then(async (response) => await response.json());
  return response;
}
