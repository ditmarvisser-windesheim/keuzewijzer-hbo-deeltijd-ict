import auth from '../api/auth';

class AuthService {
    private userIsAuthenticated: boolean;
  
    constructor() {
      this.userIsAuthenticated = false;
    }
  
    public async login(username: string, password: string): Promise<boolean> {
      // Make an API request to authenticate the user
      // Example implementation:
      try {
        const response = await auth.login({'UserName': username, 'Password': password});

        console.log(response);

        const accessToken = response.data.accessToken;
        localStorage.setItem('access_token', accessToken);
        this.userIsAuthenticated = true;
        return true;
      } catch (error) {
        console.error('Login failed:', error);
        return false;
      }
    }
  
    public logout(): void {
      // Clear the access token from local storage
      // Example implementation:
      localStorage.removeItem('access_token');
      this.userIsAuthenticated = false;
    }
  
    public isAuthenticated(): boolean {
      // Check if the user is authenticated based on the access token stored in local storage
      // Example implementation:
      const accessToken = localStorage.getItem('access_token');
      return !!accessToken;
    }
}

export default AuthService;
  