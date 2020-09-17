<template>
    <div>
        <h1 id="usersTitle">
            Manage Cards
        </h1>
        <hr />
        <div class="user-actions">
            <solar-button @button:click="showNewUserModal">
                Add Cards
            </solar-button>
        </div>
        <table id="cards" class="table">
            <tr>
                <th>Title</th>
                <th>Description</th>
                <th>Image</th>

            </tr>
            <tr v-for="card in Cards">
                <td>
                    {{ card.Title }}
                </td>
                <td>
                    {{ card.Description }}
                </td>
                <td>
                    <a href="#!">
                        <mdb-card-image data-bind="card.ShortUrl" src=card.ShortUrl alt="Card image cap"></mdb-card-image>
                        <mdb-mask flex-center waves overlay="white-slight"></mdb-mask>
                    </a>
                </td>
                
            </tr>
        </table>

        <new-User-modal @close="closeModal"
                        @save:Card="saveNewCard"
                        v-if="isUserModalVisible" />
    </div>
</template>

<script lang="ts">import { Component, Vue } from "vue-property-decorator";
    import { ICardService } from "@/types/Card";
import CardLibButton from "@/components/CardLibButton.vue";
import CardService from "@/services/card-service";
import NewCardModal from "@/components/modals/NewCardModal.vue";

    const cardService = new CardService();

@Component({
  name: "Cards",
    components: { CardLibButton, NewCardModal }
})
export default class Cards extends Vue {
    cardss: ICardService[] = [];
  isUserModalVisible: boolean = false;

  showNewCardModal() {
    this.isUserModalVisible = true;
  }

  closeModal() {
    this.isUserModalVisible = false;
  }

    async saveNewCard(newCard: ICardService) {
        await cardService.addCard(newCard);
    this.isUserModalVisible = false;
    await this.initialize();
  }

  async deleteCard(id: number) {
      await cardService.deleteCard(id);
    await this.initialize();
  }

  async initialize() {
      this.cardss = await cardService.getCards();
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

    div {
        margin-right: 0.8rem;
    }

    .user-delete {
        cursor: pointer;
        font-weight: bold;
        font-size: 1.2rem;
        color: $solar-red;
    }
</style>