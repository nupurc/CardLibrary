export interface IUserService
{
    UserId: number;
    createdOn: Date;
    updatedOn?: Date;
    firstName: string;
    lastName: string;
    UserRoleId: number;
    UserGroupId: number;
}