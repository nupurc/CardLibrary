import axios from 'axios';
import { IUserGroupService } from "@/types/UserGroup";
import { IServiceResponse } from "@/types/ServiceResponse";

/**
 * Card Service
 * Provides UI business logic associated with Customers in our system
 */
export default class UserGroupService {
    API_URL = process.env.VUE_APP_API_URL;

    public async getUserGroups(): Promise<IUserGroupService[]> {
        let result: any = await axios.get(`${this.API_URL}/group/`);
        return result.data;
    };

    public async addUserGroup(newgroup: IUserGroupService): Promise<IServiceResponse<IUserGroupService>> {
        let result: any = await axios.post(`${this.API_URL}/group/`, newgroup);
        return result.data;
    };

    public async deleteUserGroup(groupId: number): Promise<boolean> {
        let result: any = await axios.delete(`${this.API_URL}/group/${groupId}`);
        return result.data;
    };
}