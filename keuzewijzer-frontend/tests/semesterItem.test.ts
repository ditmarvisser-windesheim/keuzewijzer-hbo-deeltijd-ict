import { getCohort } from '../src/api/cohort';
import { ISemesterItem } from '../src/interfaces/iSemesterItems';

describe('getCohort', () => {
    it('should fetch and return the cohort data for a given year', async () => {
        // Mock the fetch function and return a sample response
        const mockResponse: ISemesterItem[] = [
            { id: '1', name: 'Semester 1', description: 'Description 1' },
            { id: '2', name: 'Semester 2', description: 'Description 2' },
        ];
        const fetchMock = jest.fn().mockResolvedValueOnce({
            json: jest.fn().mockResolvedValueOnce(mockResponse),
        } as unknown as Response);

        // Temporarily replace the global fetch function with the mock
        globalThis.fetch = fetchMock;

        // Call the getCohort function
        const year = 2022;
        const result = await getCohort(year);

        // Check if fetch was called with the correct URL
        expect(fetchMock).toHaveBeenCalledWith(`https://localhost:7298/api/Cohort/2022`);

        // Check if the returned data matches the mock response
        expect(result).toEqual(mockResponse);
    });
});