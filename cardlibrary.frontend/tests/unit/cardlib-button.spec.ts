import { shallowMount } from "@vue/test-utils";
import CardLibButton from "@/components/CardLibButton.vue";
import { expect } from 'chai';

describe("CardLibButton.vue", () => {
    it("displays text in default slot position", () => {
        const wrapper = shallowMount(CardLibButton, {
            propsData: {},
            slots: {
                default: "click here!"
            }
        });
        expect(wrapper.find("button").text()).toBe("click here!");
    });

    it("has underlying disabled button when disabled: true passed as prop", () => {
        const wrapper = shallowMount(CardLibButton, {
            propsData: {
                disabled: true
            },
            slots: {
                default: "foo"
            }
        });
        expect(wrapper.find("input:disabled"));
    });

    it("has no disabled on button when disabled: false passed as prop", () => {
        const wrapper = shallowMount(CardLibButton, {
            propsData: {
                disabled: false
            },
            slots: {
                default: "foo"
            }
        });
        expect(!wrapper.find("input:disabled"));
    });
});