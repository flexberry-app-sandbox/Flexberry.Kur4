import { Serializer as ПитаниеSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kur4-питание';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ПитаниеSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
