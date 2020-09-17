<!--suppress XmlUnboundNsPrefix -->

<template>
    <solar-modal>
        <template v-slot:header>
            Add New User
        </template>
        <template v-slot:body>
            <ul class="newUser">
                <li>
                    <label for="firstName">First Name</label>
                    <input type="text" id="firstName" v-model="user.firstName" />
                </li>
                <li>
                    <label for="lastName">Last Name</label>
                    <input type="text" id="lastName" v-model="user.lastName" />
                </li>
                <li>
                    <label for="lastName">User Name</label>
                    <input type="text" id="lastName" v-model="user.userName" />
                </li>
                <li>
                    <label for="address1">Password</label>
                    <input type="text"
                           id="password"
                           v-model="user.password" />
                </li>
                <li>
                    <label for="address2">Role</label>
                    <select v-model="selectedRole" class="shipmentItems" id="usrRole">
                        <option disabled value="">Please select Role</option>
                        <option v-for="item in role" :value="UserRole" :key="UserRole.UserRoleId">
                            {{ UserRole.RoleName }}
                        </option>
                    </select>
                </li>
                <li>
                    <label for="address2">Group/Feature Team</label>
                    <select v-model="selectedGroup" class="shipmentItems" id="usrGroup">
                        <option disabled value="">Please select Group</option>
                        <option v-for="item in group" :value="UserGroup" :key="UserGroup.UserGroupId">
                            {{ UserGroup.GroupName }}
                        </option>
                    </select>
                </li>

            </ul>
        </template>
        <template v-slot:footer>
            <solar-button type="button"
                          @button:click="save"
                          aria-label="save new user">
                Save Customer
            </solar-button>

            <solar-button type="button"
                          @button:click="close"
                          aria-label="Close modal">
                Close
            </solar-button>
        </template>
    </solar-modal>
</template>

<script lang="ts">
    import { Component, Vue } from "vue-property-decorator";
    import CardLibButton from "@/components/CardLibButton.vue";
    import CardModal from "@/components/modals/CardModal.vue";
    import { IUserService } from "@/types/User";
    import { IUserGroupService } from "@/types/UserGroup";
    import { IUserRoleService } from "@/types/UserRole";

    @Component({
        name: "NewUserModal",
        components: { CardLibButton, CardModal }
    })
    export default class NewUserModal extends Vue {
        user: IUserService = {
            UserId:0,
            userName: "",
            password: "",
            createdOn: new Date(),
            updatedOn: new Date(),
            firstName: "",
            lastName: "",
            UserRoleId: 1,
            UserGroupId: 1
        };
        UserRole: IUserRoleService = {
            UserRoleId: 1,
            RoleName: "",           
            createdOn: new Date(),
            updatedOn: new Date()
        };
        UserGroup: IUserGroupService = {
            UserGroupId: 1,
            GroupName: "",
            createdOn: new Date(),
            updatedOn: new Date()
        };

        save() {
            this.$emit("save:user", this.user);
        }

        close() {
            this.$emit("close");
        }
    }</script>

<style scoped lang="scss">
    .newUser {
        display: flex;
        flex-wrap: wrap;
        list-style: none;
        padding: 0;
        margin: 0;
    }

    input {
        width: 80%;
        height: 1.8rem;
        margin: 0.8rem 2rem 0.8rem 0.8rem;
        font-size: 1.1rem;
        line-height: 1.3rem;
        padding: 0.2rem;
        color: #555;
    }

    label {
        font-weight: bold;
        margin: 0.8rem;
        display: block;
    }
</style>
