import AuthService from "./AuthService";

export class ApiService {
    private readonly baseUrl: string;
    private readonly authService: AuthService;

    private constructor(baseUrl: string, authService: AuthService) {
        this.baseUrl = baseUrl;
        this.authService = authService;
    }

    private async getAuthorizationHeaders(): Promise<Record<string, string>> {
        const token = await this.authService.getAuthToken();
        return {
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json'
        };
    }

    public async get<T>(url: string): Promise<T> {
        const headers = await this.getAuthorizationHeaders();
        const response = await fetch(`${this.baseUrl}${url}`, { headers });
        return response.json();
    }

    public async post<T>(url: string, data: any): Promise<T> {
        const headers = await this.getAuthorizationHeaders();
        const response = await fetch(`${this.baseUrl}${url}`, {
            method: 'POST',
            headers,
            body: JSON.stringify(data)
        });
        return response.json();
    }

    public async delete(url: string): Promise<Response> {
        const headers = await this.getAuthorizationHeaders();
        return fetch(`${this.baseUrl}${url}`, {
            method: 'DELETE',
            headers
        });
    }
}