import { StudentsStudyrouteView } from '../src/views/Students/StudentsStudyrouteView'
import { UserUpdateRoleView } from '../src/views/User/UserUpdateRoleView'
import { IUserData } from '../src/interfaces/iUserData';

describe('FeedbackLength', () => {
    it('should return true when feedback is less than or equal to 1500 characters', async () => {
        // Arrange
        const studentsStudyrouteView = new StudentsStudyrouteView();
        const longString: string = "x".repeat(1500);

        // Act
        const result = studentsStudyrouteView.validateFeedback(longString);

        // Assert
        expect(result).toBe(true);
    });
    
    it('should return false when feedback is more than 1500 characters', async () => {
        // Arrange
        const studentsStudyrouteView = new StudentsStudyrouteView();
        const longString: string = "x".repeat(1501);
        
        // Act
        const result = studentsStudyrouteView.validateFeedback(longString);
        
        // Assert
        expect(result).toBe(false);
    });
})

