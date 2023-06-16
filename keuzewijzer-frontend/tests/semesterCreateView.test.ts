
import Swal from 'sweetalert2';

import { SemesterCreateView } from '../src/views/Module/SemesterCreateView';
import { ApiService } from '../src/services/ApiService';
import { ISemester } from '../src/interfaces/iSemester';
import { response } from 'express';


// Mock ApiService
jest.mock('../src/services/ApiService');

describe('SemesterCreateView', () => {
    describe('submitSemester', () => {
        it('should return true when the request is successful', async () => {
            // Arrange
            const apiService = new ApiService(
                'http://localhost:3000',
            );
            const semesterCreateView = new SemesterCreateView();
            semesterCreateView.apiService = apiService; // Assign the mock ApiService to the view

            const semesterItem = {
                name: 'Test Semester',
                description: 'Test Description',
                semester: 1,
                year: ['2022', '2023'],
                cohorts: [],
                cohortsId: [],
                requiredSemesterItemId: [],
                requiredSemesterItem: [],
                dependentSemesterItem: []
            };

            // Create a response object with a name property
            const response = { name: 'Test Semester' };

            // Mock the ApiService post method
            const mockPost = jest.spyOn(apiService, 'post').mockResolvedValue(response);

            // Act
            const result = await semesterCreateView.submitSemester(semesterItem);

            // Assert
            expect(mockPost).toHaveBeenCalledWith('/api/semesterItem', semesterItem);
            expect(result).toBe(true);

            // Restore the mocks
            mockPost.mockRestore();
        });

        it('should return false when an error occurs during the request', async () => {
            // Arrange
            const apiService = new ApiService(
                'http://localhost:3000',
            ); const semesterCreateView = new SemesterCreateView();
            semesterCreateView.apiService = apiService; // Assign the mock ApiService to the view

            const semesterItem = {
                name: 'Test Semester',
                description: 'Test Description',
                semester: 1,
                year: ['2022', '2023'],
                cohorts: [],
                cohortsId: [],
                requiredSemesterItemId: [],
                requiredSemesterItem: [],
                dependentSemesterItem: []
            };

            // Mock the ApiService post method to throw an error
            const mockPost = jest.spyOn(apiService, 'post').mockRejectedValue(new Error('Request failed'));

            // Act
            const result = await semesterCreateView.submitSemester(semesterItem);

            // Assert
            expect(result).toBe(false);

            // Restore the mocks
            mockPost.mockRestore();
        });
    });
});
