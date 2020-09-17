export interface IUserService
{
    UserId: number;
    userName: string;
    password: string;
    createdOn: Date;
    updatedOn?: Date;
    firstName: string;
    lastName: string;
    UserRoleId: number;
    UserGroupId: number;
}