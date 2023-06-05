class auth {
    private static readonly baseUrl = 'https://localhost:7298';

    public static async login(payload: any): Promise<any> {
        const url = '/api/Auth/login';

        try {
            const response = await fetch(this.baseUrl + url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(payload)
            }).then((response) => response.json());

            return response;
        } catch (error) {
            throw new Error('Login failed');
        }
    }
}

export default auth;