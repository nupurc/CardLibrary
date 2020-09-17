import axios from 'axios';
import { IUserService } from "@/types/User";
import { IServiceResponse } from "@/types/ServiceResponse";

/**
 * User Service
 * Provides UI business logic associated with Users in our system
 */
export default class UserService {
    API_URL = process.env.VUE_APP_API_URL;

    public async getUsers(): Promise<IUserService[]> {
        let result: any = await axios.get(`${this.API_URL}/user/`);
        return result.data;
    };

    public async addUser(newUser: IUserService): Promise<IServiceResponse<IUserService>> {
        let result: any = await axios.post(`${this.API_URL}/user/`, newUser);
        return result.data;
    };

    public async deleteUser(userId: number): Promise<boolean> {
        let result: any = await axios.delete(`${this.API_URL}/user/${userId}`);
        return result.data;
    };
}