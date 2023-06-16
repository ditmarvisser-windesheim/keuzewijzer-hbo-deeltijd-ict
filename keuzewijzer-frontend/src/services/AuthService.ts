import { IUserData } from 'interfaces/iUserData';
import { ApiService } from './ApiService';

interface LoginResult {
  status: number;
  message: string;
}

interface AuthResponse {
  status: number;
  userId: string;
  userName: string;
  email: string;
  roles: string;
}

class AuthService {
  private readonly apiService: ApiService;

  constructor(apiService: ApiService) {
    this.apiService = apiService;
  }

  public getUserData(): IUserData | null {
    var response = localStorage.getItem('user_data') ? JSON.parse(localStorage.getItem('user_data')!) : null;
    return response;
  }

  private setUserData(userData: IUserData): void {
    localStorage.setItem('user_data', JSON.stringify(userData));
  }

  public async login(username: string, password: string): Promise<LoginResult> {
    try {
      const response = await this.apiService.post<AuthResponse>('/api/Auth/login', { UserName: username, Password: password });

      var message: string = '';

      if (response.status === 401) {
        message = 'Combinatie van gebruikersnaam en wachtwoord is onjuist.';
      } else if (response.status === 429) {
        message = 'Te veel mislukte inlogpogingen, probeer het opnieuw over 1 minuut.';
      } else if (response.status === 200) {
        this.setUserData({ userId: response.userId, username: response.userName, email: response.email, roles: response.roles});
        message = 'Login successful';
      } else {
        message = 'An unknown error occurred';
      }

      return {
        status: response.status,
        message: message
      };
    } catch (error) {
      console.error('Error login', error);

      return {
        status: 500,
        message: 'An unknown error occurred'
      };
    }
  }

  public async logout(): Promise<void> {
    localStorage.removeItem('user_data');

    try {
      await this.apiService.post('/api/Auth/logout', {});
    } catch (error) {
      console.error('Error logout', error);
    }
  }

  public isAuthenticated(): boolean {
    try {
      const userData = this.getUserData();
      return userData !== null;
    } catch (error) {
      console.log('isAuthenticated', error);
      return false;
    }
  }
}

export default AuthService;
