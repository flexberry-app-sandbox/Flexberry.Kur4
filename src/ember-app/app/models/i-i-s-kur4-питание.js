import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ПитаниеMixin
} from '../mixins/regenerated/models/i-i-s-kur4-питание';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ПитаниеMixin, Validations, {
});

defineProjections(Model);

export default Model;
