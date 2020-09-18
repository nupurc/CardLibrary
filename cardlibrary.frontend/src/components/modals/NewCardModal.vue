<template>
    <solar-modal>
        <template v-slot:header>
            Add New Product
        </template>
        <template v-slot:body>
            <ul class="newCard">
                <mdb-card>
                    <mdb-card-image src="https://mdbootstrap.com/img/Photos/Horizontal/Nature/4-col/img%20%286%29.jpg" alt="Card image cap"></mdb-card-image>
                    <mdb-card-body>
                        <mdb-card-title>Basic card</mdb-card-title>
                        <mdb-card-text>Some quick example text to build on the card title and make up the bulk of the card's content.</mdb-card-text>
                        <mdb-btn color="primary">Button</mdb-btn>
                    </mdb-card-body>
                </mdb-card>
                <mdb-card>
                    <mdb-view hover>
                        <a href="#!">
                            <mdb-card-image src="https://mdbootstrap.com/img/Photos/Horizontal/Nature/4-col/img%20%282%29.jpg" alt="Card image cap" />
                            <mdb-mask flex-center waves overlay="white-slight"></mdb-mask>
                        </a>
                    </mdb-view>
                    <mdb-card-body>
                        <mdb-card-title>Card with waves effect</mdb-card-title>
                        <mdb-card-text>Some quick example text to build on the card title and make up the bulk of the card's content.</mdb-card-text>
                        <mdb-btn color="primary">Button</mdb-btn>
                    </mdb-card-body>
                </mdb-card>
                <mdb-card>
                    <mdb-card-image src="https://mdbootstrap.com/img/Photos/Others/photo6.jpg" alt="Card image cap"></mdb-card-image>
                    <mdb-card-body>
                        <mdb-card-title>Basic card</mdb-card-title>
                        <mdb-card-text>Lorem ipsum dolor sit amet, consectetur</mdb-card-text>
                        <mdb-btn color="primary">Button</mdb-btn>
                    </mdb-card-body>
                </mdb-card>
                <mdb-card>
                    <mdb-card-image src="https://mdbootstrap.com/img/Photos/Others/men.jpg" alt="Card image cap"></mdb-card-image>
                    <mdb-card-body>
                        <mdb-card-title>Basic card</mdb-card-title>
                        <mdb-card-text> Facere modi sunt, quod quibusdam dignissimos neque rem nihil</mdb-card-text>
                        <mdb-btn color="primary">Button</mdb-btn>
                    </mdb-card-body>
                </mdb-card>
                <mdb-card>
                    <mdb-card-image src="newCard.ShortUrl" alt="Card image cap"></mdb-card-image>
                    <mdb-card-body>
                        <mdb-card-title data-bind="newCard.Title"></mdb-card-title>
                        <mdb-card-text data-bind="newCard.Description"> Facere modi sunt, quod quibusdam dignissimos neque rem nihil</mdb-card-text>
                        <mdb-btn color="primary">Button</mdb-btn>
                    </mdb-card-body>
                </mdb-card>
            </ul>
        </template>
        <template v-slot:footer>
            <solar-button type="button"
                          @click.native="save"
                          aria-label="save new item">
                Save Product
            </solar-button>
            <solar-button type="button"
                          @click.native="close"
                          aria-label="close modal">
                Close
            </solar-button>
        </template>
    </solar-modal>
</template>

<script lang="ts">
    // @ts-ignore
    import { mdbCard } from "@/components/mdbvue/lib/components/mdbCard";
    // @ts-ignore
    import { mdbCardImage } from "@/components/mdbvue/lib/components/mdbCardImage";
    // @ts-ignore
    import { mdbCardBody } from "@/components/mdbvue/lib/components/mdbCardBody";
    // @ts-ignore
    import { mdbCardTitle } from "@/components/mdbvue/lib/components/mdbCardTitle";
    // @ts-ignore
    import { mdbCardText } from "@/components/mdbvue/lib/components/mdbCardText";
    // @ts-ignore
    import { mdbBtn } from "@/components/mdbvue/lib/components/mdbBtn";
    // @ts-ignore
    import { mdbView } from "@/components/mdbvue/lib/components/mdbView";
    // @ts-ignore
    import { mdbMask } from "@/components/mdbvue/lib/components/mdbMask";   

    import { Component, Prop, Vue } from "vue-property-decorator";
 import CardLibButton from "@/components/CardLibButton.vue";
 import CardModal from "@/components/modals/CardModal.vue";
import { ICardService } from "@/types/Card";

@Component({
  name: "NewCardModal",
    components: {
        CardLibButton,
        CardModal,
        mdbCard,
        mdbCardImage,
        mdbCardBody,
        mdbCardTitle,
        mdbCardText,
        mdbBtn,
        mdbView,
        mdbMask}
})
export default class NewProductModal extends Vue {
    newCard: ICardService = {
    createdOn: new Date(),
    updatedOn: new Date(),
        CardId: 0,
        Title : "",
        Description: "",
        ShortUrl: "",
        CardImage: new ImageBitmap()
  };

  close() {
    this.$emit("close");
  }

  save() {
      this.$emit("save:card", this.newCard);
  }
}</script>

<style scoped lang="scss">
    .newCard {
        list-style: none;
        padding: 0;
        margin: 0;
    }
        input
    {
        width: 100%;
        height: 1.8rem;
        margin-bottom: 1.2rem;
        font-size: 1.1rem;
        line-height: 1.3rem;
        padding: 0.2rem;
        color: #555;
    }

    label {
        font-weight: bold;
        display: block;
        margin-bottom: 0.3rem;
    }
    
</style>