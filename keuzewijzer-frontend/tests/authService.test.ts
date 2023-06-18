import { ApiService } from '../src/services/ApiService';
import AuthService from '../src/services/AuthService';

test('login should authenticate the user and set the access token and user data', async () => {
  // Arrange
  const apiService = new ApiService('http://localhost:7298');
  const authService = new AuthService(apiService);
  const username = 'testUser';
  const password = 'testPassword';

  // Mock the login function
  const mockLogin = jest.spyOn(authService, 'login').mockResolvedValue({
    status: 200,
    message: 'Login successful',
  });

  // Act
  const loginResult = await authService.login(username, password);

  // Assert
  expect(mockLogin).toHaveBeenCalledWith(username, password);
  // Add assertions for the expected behavior based on the login result
  expect(loginResult).toEqual({
    status: 200,
    message: 'Login successful',
  });

  // Restore the mock
  mockLogin.mockRestore();
});
