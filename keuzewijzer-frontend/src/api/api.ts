class Api {
    //TODO: change this to env
    private static readonly baseUrl = 'https://localhost:7298';

    static async get(url: string): Promise<any> {
        const response = await fetch(this.baseUrl + url).then((response) => { return response.json() });
        return response;
    }

    static async post(url: string, payload: any) {
        const response = await fetch(this.baseUrl + url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(payload)
        });
        const data = await response.json();
        return data;
    }

    static async put(url: string, payload: any) {
        const response = await fetch(this.baseUrl + url, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(payload)
        });
        const data = await response.json();
        return data;
    }

    static async delete(url: string) {
        const response = await fetch(this.baseUrl + url, {
            method: 'DELETE'
        });
        return response;
    }
}

export default Api;