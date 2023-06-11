import { type ICohort } from 'interfaces/iCohort';

class cohort {
  static async getCohorts (): Promise<ICohort[]> {
    const response = await fetch('https://localhost:7298/api/Cohort').then(async (response) => { return await response.json(); });
    return response;
  }
}

export default cohort;
