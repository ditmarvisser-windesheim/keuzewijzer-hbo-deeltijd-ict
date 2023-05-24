class Api {
    static async get(url: string) {
        const response = await fetch(url).then((response) => response.json());
        return response;
    }

    static async post(url: string, payload: any) {
        const response = await fetch(url, {
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
        const response = await fetch(url, {
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
        const response = await fetch(url, {
            method: 'DELETE'
        });
        const data = await response.json();
        return data;
    }
}

export default Api;