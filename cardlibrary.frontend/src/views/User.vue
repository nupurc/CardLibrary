<template>
    <div>
        <h1 id="usersTitle">
            Manage Users
        </h1>
        <hr />
        <div class="user-actions">
            <solar-button @button:click="showNewUserModal">
                Add Users
            </solar-button>
        </div>
        <table id="users" class="table">
            <tr>
                <th>User</th>
                <th>User Name</th>
                <th>Role</th>
                <th>Group</th>
                
            </tr>
            <tr v-for="user in Users">
                <td>
                    {{ user.firstName + " " + user.lastName }}
                </td>
                <td>
                    {{ user.userName }}
                </td>
                <td>
                    <select class="shipmentItems" id="usrRole">
                        <option disabled value="">Admin</option>                        
                    </select>
                </td>
                <td>
                    <select class="shipmentItems" id="usrRole">
                        <option disabled value="">FFC</option>
                    </select>
                </td>
                <td>
                    {{ User.createdOn | humanizeDate }}
                </td>               
            </tr>
        </table>

        <new-User-modal @close="closeModal"
                            @save:User="saveNewUser"
                            v-if="isUserModalVisible" />
    </div>
</template>

<script lang="ts">import { Component, Vue } from "vue-property-decorator";
import { IUserService } from "@/types/User";
import CardLibButton from "@/components/CardLibButton.vue";
import UserService from "@/services/user-service";
import NewUserModal from "@/components/modals/NewUserModal.vue";

const userService = new UserService();

@Component({
  name: "Users",
    components: { CardLibButton, NewUserModal }
})
export default class Users extends Vue {
    userss: IUserService[] = [];
  isUserModalVisible: boolean = false;

  showNewUserModal() {
    this.isUserModalVisible = true;
  }

  closeModal() {
    this.isUserModalVisible = false;
  }

    async saveNewUser(newUser: IUserService) {
        await userService.addUser(newUser);
    this.isUserModalVisible = false;
    await this.initialize();
  }

  async deleteUser(id: number) {
      await userService.deleteUser(id);
    await this.initialize();
  }

  async initialize() {
      this.userss = await userService.getUsers();
  }

  async created() {
    await this.initialize();
  }
}</script>

<style scoped lang="scss">
    @import "@/scss/global.scss";

    .user-actions {
        display: flex;
        margin-bottom: 0.8rem;
    }
        div

    {
        margin-right: 0.8rem;
    }   

    .user-delete {
        cursor: pointer;
        font-weight: bold;
        font-size: 1.2rem;
        color: $solar-red;
    }
</style>