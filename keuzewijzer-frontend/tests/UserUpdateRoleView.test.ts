import { UserUpdateRoleView } from '../src/views/User/UserUpdateRoleView'
import { IUserData } from '../src/interfaces/iUserData';

// Mock ApiService
jest.mock('../src/services/ApiService');

describe('StudentRoles', () => {
    it('should return true when student only has student roles', async () => {
        // Arrange
        const userUpdateRoleView = new UserUpdateRoleView();

        const roles = ["Student"]

        // Act
        const result = userUpdateRoleView.validateInputStudents(roles, "1");

        // Assert
        expect(result).toBe(true);
    });

    it('should return false when student has other roles', async () => {
        // Arrange
        const userUpdateRoleView = new UserUpdateRoleView();

        const roles = ["Student", "Studiebegeleider"]

        // Act
        const result = userUpdateRoleView.validateInputStudents(roles, "1");

        // Assert
        expect(result).toBe(false);
    })
})

describe('AdminRoles', () => {
    it('should return true when admin does not remove own admin role', async () => {
        // Arrange
        const userUpdateRoleView = new UserUpdateRoleView();

        const roles = ["Administrator", "Studiebegeleider"]

        const userdata: IUserData = {
            userId: "1",
            username: "",
            email: "",
            roles: "",
        }

        // Act
        const result = userUpdateRoleView.validateInputAdmin(roles, "1", userdata);

        // Assert
        expect(result).toBe(true);
    });

    it('should return true when admin removes role of other admin', async () => {
        // Arrange
        const userUpdateRoleView = new UserUpdateRoleView();

        const roles = ["Studiebegeleider"]

        const userdata: IUserData = {
            userId: "1",
            username: "",
            email: "",
            roles: "",
        }

        // Act
        const result = userUpdateRoleView.validateInputAdmin(roles, "2", userdata);

        // Assert
        expect(result).toBe(true);
    });

    it('should return false when admin removes own admin role', async () => {
        // Arrange
        const userUpdateRoleView = new UserUpdateRoleView();

        const roles = ["Studiebegeleider"]

        const userdata: IUserData = {
            userId: "1",
            username: "",
            email: "",
            roles: "",
        }

        // Act
        const result = userUpdateRoleView.validateInputAdmin(roles, "1", userdata);

        // Assert
        expect(result).toBe(false);
    })
})
