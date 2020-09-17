import axios from 'axios';
import { IUserRoleService } from "@/types/UserRole";
import { IServiceResponse } from "@/types/ServiceResponse";

/**
 * Card Service
 * Provides UI business logic associated with Customers in our system
 */
export default class UserRoleService {
    API_URL = process.env.VUE_APP_API_URL;

    public async getUserRoles(): Promise<IUserRoleService[]> {
        let result: any = await axios.get(`${this.API_URL}/role/`);
        return result.data;
    };

    public async addUserRole(newrole: IUserRoleService): Promise<IServiceResponse<IUserRoleService>> {
        let result: any = await axios.post(`${this.API_URL}/role/`, newrole);
        return result.data;
    };

    public async deleteUserRole(roleId: number): Promise<boolean> {
        let result: any = await axios.delete(`${this.API_URL}/card/${roleId}`);
        return result.data;
    };
}